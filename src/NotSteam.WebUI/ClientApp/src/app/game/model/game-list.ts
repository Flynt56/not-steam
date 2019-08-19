import { BaseEntity } from 'src/app/shared/Model/base-entity';

export interface GameList extends BaseEntity {
    title: string;
    releaseDate: string;
    basePrice: number;
    tags: Array<string>;
}
