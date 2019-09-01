export class AuthUser {
    id: number;
    email: string;
}

export class AuthResponse {
    token: string;
    user: AuthUser;
}


