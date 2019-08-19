import { BaseEntity } from 'src/app/shared/Model/base-entity';

export interface UserList extends BaseEntity {
    name: string;
    email: string;
    dob: string;
    nick?: string;
}
