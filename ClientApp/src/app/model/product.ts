import { KeyValuePair } from "./KeyValuePair";

export interface Product {
    id: number;
    brand: KeyValuePair;
    model: KeyValuePair;
    frameColor: KeyValuePair;
    templeColor: KeyValuePair;
    lensColor: KeyValuePair;
    frameMaterial: KeyValuePair;
    templeMaterial: KeyValuePair;
    lensMaterial: KeyValuePair;
    categories: KeyValuePair;
    style: KeyValuePair;
    frameType: KeyValuePair;
    idealFor: KeyValuePair;
    sku: string;
    colorVariationName: string;
    sizeVariationName: string;
    brandColorName: string;
    brandSizeName: string;
    size: KeyValuePair;
    lastUpdate: string;
}
