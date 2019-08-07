import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CompanyModule } from './company/company.module';
import { GameModule } from './game/game.module';
import { HttpClientModule } from '@angular/common/http';
import { UserModule } from './user/user.module';
import { PurchaseModule } from './purchase/purchase.module';
import { LibraryModule } from './library/library.module';
import { ReviewModule } from './review/review.module';
import { TagModule } from './tag/tag.module';
import { GametagModule } from './gametag/gametag.module';
import { NavbarComponent } from './template/navbar/navbar.component';
import { FooterComponent } from './template/footer/footer.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CompanyModule,
    GameModule,
    UserModule,
    PurchaseModule,
    LibraryModule,
    ReviewModule,
    TagModule,
    GametagModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
