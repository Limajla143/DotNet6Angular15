# DotNet6Angular15

API commands notes

dotnet dev-certs
dotnet dev-certs https --clean
dotnet dev-certs https --trust

#Migrations
Drop-Database -p Infrastructure -s API
Remove-Migration -p Infrastructure -s API
Add-Migration InitialCreate -p Infrastructure -s API -c StoreDBContext -o Data/Migrations
Update-Database

#IdentityDb
Add-Migration IdentityInitial -p Infrastructure -s API -c AppIdentityDbContext -o Identity/Migrations
Drop-Database -Context AppIdentityDbContext -p Infrastructure -s API
Remove-Migration -Context AppIdentityDbContext -p Infrastructure -s API


# Angular Commands
ng new clientEcommerce

# Enable HTTPS angular
install mkcert

# Ngx-bootstrap
ng add ngx-bootstrap

npm install font-awesome

ng g c nav-bar --skip-tests
ng g c shop/shop --flat --skip-tests
ng g interceptor core/interceptors/loading --skip-tests
ng g s core/services/busy --skip-tests
ng g --help /** FOR MORE COMMANDS **/
ng g interceptor core/interceptors/jwt --skip-tests

# Angular Notifs
npm install ngx-toastr --save

#Angular xng-BreadCrumb
npm install --save xng-breadcrumb

#Bootsrap Theme
bootswatch.com
npm install bootswatch

#loading indicator
npm install ngx-spinner --save

# Docker
docker-compose up --detach (RUN REDIS IN DOCKER)

# ANGULAR GUARD
ng g g core/guards/auth


# Stepper steps checkout
ng add @angular/cdk

#

