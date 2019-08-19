import { BaseEntity } from 'src/app/shared/Model/base-entity';

export interface TagDetails extends BaseEntity {
    name: string;
    usageAmount: number;
    description?: string;
}
