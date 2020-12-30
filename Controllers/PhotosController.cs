using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using doublebattery.Controllers.Resources;
using doublebattery.Core;
using doublebattery.Core.Models;
using doublebattery.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace doublebattery.Controllers
{
    [Route("/api/products/{productId}/photos")]
    public class PhotosController : Controller
    {
        private readonly IProductRepository repository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment host;
        private readonly string[] ACCEPTED_FILE_TYPE = new[] { ".jpeg", ".jpg", ".png" };
        private readonly int MAX_BYTES = 10 * 1024 * 1024;
        private readonly PhotoRepository photoRepository;

        public PhotosController(
            IWebHostEnvironment host,
            IProductRepository repository,
            IUnitOfWork unitOfWork,
            IMapper mapper,
            PhotoRepository photoRepository)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.repository = repository;
            this.host = host;
            this.photoRepository = photoRepository;

        }


        [HttpPost]
        public async Task<IActionResult> Upload(int productId, IFormFile file)
        {
            var product = await repository.GetProduct(productId, includeRelated: false);

            if (product == null)
                return NotFound();
            if (file == null) return BadRequest("Null File");
            if (file.Length == 0) return BadRequest("Null File");
            if (file.Length > MAX_BYTES) return BadRequest("File size cannot exceed 10 MB");
            if (!ACCEPTED_FILE_TYPE.Any(s => s == Path.GetExtension(file.FileName).ToLower())) return BadRequest("Invalid File Type");


            var uploadsPath = Path.Combine(host.WebRootPath, "uploads");
            if (!Directory.Exists(uploadsPath))
                Directory.CreateDirectory(uploadsPath);

            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            var filePath = Path.Combine(uploadsPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            var photo = new Photo { FileName = fileName };

            product.Photos.Add(photo);

            await unitOfWork.CompleteAsync();

            return Ok(mapper.Map<Photo, PhotoResource>(photo));
        }

        public async Task<IEnumerable<PhotoResource>> GetPhotos(int productId)
        {
            var photo = await photoRepository.GetPhotos(productId);
            return mapper.Map<IEnumerable<Photo>, IEnumerable<PhotoResource>>(photo);
        }
    }
}