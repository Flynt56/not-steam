import { BaseEntity } from 'src/app/shared/Model/base-entity';

export interface GameDetails extends BaseEntity {
    title: string;
    releaseDate: string;
    basePrice: number;
    companyId: number;
    description?: string;
}
