import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GametagFormComponent } from './gametag-form.component';

describe('GametagFormComponent', () => {
  let component: GametagFormComponent;
  let fixture: ComponentFixture<GametagFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GametagFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GametagFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
