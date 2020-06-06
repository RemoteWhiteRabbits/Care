# enter service name here (for example, Profile)
Param([string]$serviceName)

# check if directory exists, error if does
$pathExists = Test-Path ".\$($serviceName)"
if ($pathExists){
	throw [System.ArgumentException] "$serviceName folder already exists"
}

# create root directory
mkdir $serviceName
cd $serviceName

# for each package:
# 	create folder
# 	create code project
# 	create test project
# 	create solution file
# 	link projects to solution
# 	link code project to test project

# API
mkdir API
cd API
dotnet new webapi --name "$($serviceName).API"
dotnet new nunit --name "$($serviceName).API.Test"
dotnet new sln --name "$($serviceName).API"
dotnet sln "$($serviceName).API.sln" add "$($serviceName).API\$($serviceName).API.csproj" "$($serviceName).API.Test\$($serviceName).API.Test.csproj"
dotnet sln "$($serviceName).API.sln" add "$($serviceName).API.Test\$($serviceName).API.Test.csproj"
dotnet add "$($serviceName).API.Test\$($serviceName).API.Test.csproj" reference "$($serviceName).API\$($serviceName).API.csproj"
cd ..

# Application
mkdir Application
cd Application
dotnet new classlib --name "$($serviceName).Application"
dotnet new nunit --name "$($serviceName).Application.Test"
dotnet new sln --name "$($serviceName).Application"
dotnet sln "$($serviceName).Application.sln" add "$($serviceName).Application\$($serviceName).Application.csproj"
dotnet sln "$($serviceName).Application.sln" add "$($serviceName).Application.Test\$($serviceName).Application.Test.csproj"
dotnet add "$($serviceName).Application.Test\$($serviceName).Application.Test.csproj" reference "$($serviceName).Application\$($serviceName).Application.csproj"
cd ..

# Domain
mkdir Domain
cd Domain
dotnet new classlib --name "$($serviceName).Domain"
dotnet new nunit --name "$($serviceName).Domain.Test"
dotnet new sln --name "$($serviceName).Domain"
dotnet sln "$($serviceName).Domain.sln" add "$($serviceName).Domain\$($serviceName).Domain.csproj"
dotnet sln "$($serviceName).Domain.sln" add "$($serviceName).Domain.Test\$($serviceName).Domain.Test.csproj"
dotnet add "$($serviceName).Domain.Test\$($serviceName).Domain.Test.csproj" reference "$($serviceName).Domain\$($serviceName).Domain.csproj"
cd ..

cd..
