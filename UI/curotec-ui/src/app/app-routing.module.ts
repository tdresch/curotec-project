import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JobCategoryComponent } from './features/job-category/job-category/job-category.component';
import { AddJobCategoryComponent } from './features/job-category/add-job-category/add-job-category/add-job-category.component';

const routes: Routes = [
  {
    path: 'admin/jobcategory',
    component: JobCategoryComponent,
  },
  {
    path: 'admin/jobcategory/add',
    component: AddJobCategoryComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
