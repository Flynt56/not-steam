import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class GameList implements BaseEntity {
    id: number;
    title: string;
    releaseDate: string;
    basePrice: number;
    tags: Array<string>;
}
