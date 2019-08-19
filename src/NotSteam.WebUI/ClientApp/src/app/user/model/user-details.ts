import { BaseEntity } from 'src/app/shared/Model/base-entity';

export interface UserDetails extends BaseEntity {
    name: string;
    dob: string;
    password: string;
    email: string;
    nick?: string;
    profileImageUri?: string;
}
