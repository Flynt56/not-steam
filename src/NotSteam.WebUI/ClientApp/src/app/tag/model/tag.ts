import { BaseEntity } from 'src/app/shared/Model/base-entity';

export interface Tag extends BaseEntity {
    name: string;
    description?: string;
}
