import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GametagListComponent } from './gametag-list.component';

describe('GametagListComponent', () => {
  let component: GametagListComponent;
  let fixture: ComponentFixture<GametagListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GametagListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GametagListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
