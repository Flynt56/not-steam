import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class TagDetails implements BaseEntity {
    id: number;
    name: string;
    usageAmount: number;
    description?: string;
}
