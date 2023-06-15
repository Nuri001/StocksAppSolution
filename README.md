# StocksAppSolution
An Asp.Net Core Web Application that displays stock price with live updates from "https://finnhub.io/".<br>
App Building Instructions :<br>
1.Create controller(s) with attribute routing. <br>
2.Provide the configuration as service, using Options pattern.<br>
3.Inject the IOptions in the controller.<br>
4.Use CSS styles, layout views, _ViewImports, _ViewStart as per the necessity.<br>
5.The CSS file is provided as downlodable resource for applying essential styles. You can download and use it.<br>
6.Inject essential services such as IFinnhubCompanyProfileService and other services in Controller. Invoke IStocksRepository and IFinnhubRepository in respective service classes.<br>
7.Invoke essential service methods in controller.<br>
8.The Entity model class (BuyOrder and SellOrder) should not be accessed in the controller. They must be used only in the service classes.<br>
9.The DTO model classes (BuyOrderRequest, BuyOrderResponse, SellOrderRequest, SellOrderResponse) should be used as parameter type or return type in the service methods; and can be used in both services and controller.<br>
10.Use appropriate tag helpers such as "asp-controller", "asp-action", "asp-for" etc., in all views wherever necessary.<br>
11.Write appropriate logs using ILogger, in controllers and services.<br>
12.In case of non-Development environment, apply both custom exception handling middleware (i.e. ExceptionHandlingMiddleware) and also built-in error handling middleware called "UseExceptionHandler".<br>
13.Apply SOLID principles such as 'Interface Segregation Principle', 'Single Responsibility Principle', 'Dependency Inversion Principle' and other principles while creating services and other classes.<br>
14.Use clean architecture to create layers of this application.<br>

