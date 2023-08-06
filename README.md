# DotNet6Angular15

API commands notes

dotnet dev-certs
dotnet dev-certs https --clean
dotnet dev-certs https --trust

#Migrations
Drop-Database -p Infrastructure -s API
Remove-Migration -p Infrastructure -s API
Add-Migration InitialCreate -p Infrastructure -s API -o Data/Migrations
Update-Database


# Angular Commands
ng new clientEcommerce

# Enable HTTPS angular
install mkcert

# Ngx-bootstrap
ng add ngx-bootstrap

npm install font-awesome

ng g c nav-bar --skip-tests
ng g c shop/shop --flat --skip-tests
ng g --help /** FOR MORE COMMANDS **/

# Angular Notifs
npm install ngx-toastr --save