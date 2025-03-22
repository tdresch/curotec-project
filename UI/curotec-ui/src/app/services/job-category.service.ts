import { Injectable } from '@angular/core';
import { AddJobCategoryRequest } from '../models/add-job-category-request.model';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../environments/environment';
import { JobCategoryResponse } from '../models/job-category-response.model';

@Injectable({
  providedIn: 'root',
})
export class JobCategoryService {
  private readonly baseUrl = environment.apiBaseUrl + '/jobcategories';

  constructor(private readonly http: HttpClient) {}

  addJobCategory(model: AddJobCategoryRequest): Observable<void> {
    return this.http.post<void>(this.baseUrl, model);
  }

  getJobCategories(): Observable<JobCategoryResponse[]> {
    return this.http.get<JobCategoryResponse[]>(this.baseUrl);
  }
}
