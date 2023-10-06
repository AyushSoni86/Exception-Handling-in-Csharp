# FlexurProbation

### Assignment 1: Custom Exception Implementation 

-  Create a custom exception class called InvalidEmpNameException that inherits from the System.Exception class. This exception should be used to handle cases where an employee name contains special characters or numeric values. 

- Implement the necessary constructors for this custom exception class, allowing you to pass custom error messages and possibly inner exceptions. 

- In a department application, write code to validate employee names for any special characters or numeric values and throw the InvalidEmpNameException when such characters are detected. 

### Assignment 2: Exception Handling in Employee Registration 

- Develop an employee registration module within your department application. 

- In this module, create a form or input mechanism that allows users to enter employee information, including their name. 

- Implement custom exception handling to validate the employee name as it is entered. If the name contains special characters or numeric values, throw the InvalidEmpNameException. 

- Catch and handle this exception appropriately, displaying an error message to the user and preventing the registration of employees with invalid names. 

### Assignment 3: Handling Multiple Custom Exceptions 

- Expand your department application to handle multiple custom exceptions, including the InvalidEmpNameException. For example, you can create a DepartmentNotFoundException or an EmployeeNotFoundException. 

- Implement appropriate error-handling strategies for each custom exception type. 

- Ensure that your application can gracefully handle and differentiate between these custom exceptions. 
