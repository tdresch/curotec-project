import { Component, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs';
import { AddJobCategoryRequest } from 'src/app/models/add-job-category-request.model';
import { JobCategoryService } from 'src/app/services/job-category.service';

@Component({
  selector: 'app-add-job-category',
  templateUrl: './add-job-category.component.html',
  styleUrls: ['./add-job-category.component.scss'],
})
export class AddJobCategoryComponent implements OnDestroy {
  model: AddJobCategoryRequest;

  private addJobCategorySubscription?: Subscription;

  constructor(private readonly jobCategoryService: JobCategoryService) {
    this.model = {
      name: '',
    };
  }

  onSubmit() {
    this.addJobCategorySubscription = this.jobCategoryService
      .addJobCategory(this.model)
      .subscribe({
        next: (response) => {
          this.model.name = '';
          console.log('Job category added successfully');
        },
        error: (error) => {
          console.error('Error adding job category', error);
        },
      });
  }

  ngOnDestroy(): void {
    this.addJobCategorySubscription?.unsubscribe();
  }
}
