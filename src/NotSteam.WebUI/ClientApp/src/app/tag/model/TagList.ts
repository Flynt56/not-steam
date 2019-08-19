import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class TagList implements BaseEntity {
    id: number;
    name: string;
    usageAmount: number;
}
