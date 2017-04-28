# TargetProcessServicesApi

an api built for interacting with Target Process' RestFUL api.


# Usage Examples
---
    public void Example()
    {
         // Create a request handler
         var requestHandler = new ServiceRequestHandler(

          //  Define the url for your company.
          new Uri("https://companyname.tpondemand.com/"), 

          // Pass the username you have defined in target process to work with services
          "Username",
         
          // You have to pass the password as a secure string.
          "password".ConvertToSecureString());

          // Create the service provider by passing in the request handler
	        var serviceProvider = new ServiceProvider(requestHandler);
	
	        // Use the service
	        CompanyCrudOps(serviceProvider.FetchInstance<ICompanyService>());
	
	        // These are the only serivces currently supported.
	        var taskService = serviceProvider.FetchInstance<ITaskService>();
	        var bugService = serviceProvider.FetchInstance<IBugService>();
	        var programService = serviceProvider.FetchInstance<IProgramService>();
	        var epicService = serviceProvider.FetchInstance<IEpicService>();
	        var commentService = serviceProvider.FetchInstance<ICommentService>();
	        var featureService = serviceProvider.FetchInstance<IFeatureService>();
	        var timeService = serviceProvider.FetchInstance<ITimeService>();
	        var fetchInstance = serviceProvider.FetchInstance<IUserService>();
	        var requestService = serviceProvider.FetchInstance<IRequestService>();
	        var projectService = serviceProvider.FetchInstance<IProjectService>();
	    }
	
	    public static void CompanyCrudOps(ICompanyService companyService)
	    {
	        // instanciate a new Company
	        var company = new Company
	        {
	            Name = "Api Unit Test",
	            Description = "Call from unit test",
	            Url = "https://www.ApiUnitTests.com"
	        };
	
	        // Send the company to the service to be created.
	        company = companyService.Create(company).Result;
	
	        // Get Example
	        var companyId = 90;
	        var otherCompany = companyService.GetEntityById<Company>(companyId).Result;
	
	        // Update Example
	        otherCompany.Name = "Some Different Name";
	        companyService.Update(otherCompany);
	
	        // Delete Example
	        var deleteResult = companyService.Delete(otherCompany);
	    }
