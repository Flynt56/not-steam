import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class UserList implements BaseEntity {
    id: number;
    name: string;
    email: string;
    dob: string;
    nick?: string;
}
