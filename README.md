# Data Pagination

Data paging using ASP.NET Core 2.2 and Entity Framework Core 2.2.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

```
Visual Studio 2017+ / Code
```

### Installing

Just compile and run. The below endpoint is available:
```
GET api/pointOfInterest?page=1&pageSize=10
```

### Notes

In this example we are querying our databse two times (2 trips to database):
```
RowCount = await query.CountAsync()
...
result.Results = await query.Skip(skip).Take(pageSize).ToListAsync();
```

You can remove the .CountAsync() call. Your client should stop requesting the server once it obtain an empty array list.

## Built With

* [ASP.NET Core 2.2](https://dotnet.microsoft.com/)
* [Entity Framework Core 2.2](https://github.com/aspnet/EntityFrameworkCore)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
