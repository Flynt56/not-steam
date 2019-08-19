import { BaseEntity } from 'src/app/shared/Model/base-entity';

export class User implements BaseEntity {
    id: number;
    username: string;
    password: string;
    email: string;
    dateOfBirth: string;
    nickname?: string;
    profileImageUri?: string;
}
