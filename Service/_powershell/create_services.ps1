# enter the names of the services proyects
Param([string[]]$servicesName)

cd ..

# for each service in servicesName verify the name of the project and call the script to create the service 
foreach ($service in $servicesName){
	& .\_powershell\create_service.ps1 $service
}