import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class Game implements BaseEntity {
    id: number;
    title: string;
    releaseDate: string;
    basePrice: number;
    companyId: number;
    description?: string;
}
