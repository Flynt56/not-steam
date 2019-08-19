import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class UserDetails implements BaseEntity {
    id: number;
    name: string;
    dob: string;
    password: string;
    email: string;
    nick?: string;
    profileImageUri?: string;
}
