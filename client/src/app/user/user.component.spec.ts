 import { async, ComponentFixture, TestBed } from '@angular/core/testing';
 import { UserComponent } from './user.component';
 import{AppModule} from 'src/app/app.module';
 describe('UserComponent', () => {
   let component: UserComponent;
   let fixture: ComponentFixture<UserComponent>;

   beforeEach(async(() => {
     TestBed.configureTestingModule({
       declarations: [  ],
       imports : [AppModule]
     })
     .compileComponents();
   }));

   beforeEach(() => {
     fixture = TestBed.createComponent(UserComponent);
     component = fixture.componentInstance;
     fixture.detectChanges();
   });

   it('should create', () => {
     expect(component).toBeTruthy();
   });
 });
