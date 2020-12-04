import { KeyValuePair } from "./KeyValuePair";

export interface Product {
    id: number;
    brand: KeyValuePair;
    model: KeyValuePair;
    colorChildId: string;
    sizeChildId: string;
    brandColorName: string;
    brandSizeName: string;
    categories: KeyValuePair;
    style: KeyValuePair;
    frameType: KeyValuePair;
    frameColor: KeyValuePair;
    templeColor: KeyValuePair;
    lensColor: KeyValuePair;
    frameMaterial: KeyValuePair;
    templeMaterial: KeyValuePair;
    lensMaterial: KeyValuePair;
    idealFor: KeyValuePair;
    sku: string;
    size: KeyValuePair;
    lastUpdate: string;
    createdOn: string;
    lensWidth: number;
    lensHeight: number;
    bridgeSize: number;
    templeLength: number
}
