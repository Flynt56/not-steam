import { BaseEntity } from 'src/app/shared/Model/base-entity';

export interface TagList extends BaseEntity {
    name: string;
    usageAmount: number;
}
