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

# Some Commands to add sample features
ng g m orders
ng g m orders/orders-routing --flat
ng g c orders/orders --flat --skip-tests
ng g s orders/orders --skip-tests
ng g c order-detailed --skip-tests

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
docker-compose up -d

# ANGULAR GUARD
ng g g core/guards/auth


# Stepper steps checkout
ng add @angular/cdk

# Stripe
npm install @stripe/stripe-js

install stripe cmd then
-stripe login
-stripe listen -f https://localhost:7164/api/payments/webhook -e payment_intent.succeeded,payment_intent.payment_failed

# Angular build
ng build

# Switch to Postgre
Add-Migration PostgreInitial -p Infrastructure -s API -c StoreDBContext -o Data/Migrations
Add-Migration PostgreIdentity -p Infrastructure -s API -c AppIdentityDbContext -o Identity/Migrations