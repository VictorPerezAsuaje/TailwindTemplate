# Tailwind Template

This is a sample pre-configured VS2022 template based on the Writer's Den project that contains:

1. NET 8 MVC web application
2. Layered architecture with Domain, Infrastructure, Application and UI projects precreated.
3. TailwindCSS & PostCSS preconfigured with theme colors for dark-light themes.
4. Pre-made partials for the layout, menu and sidebar with partials
5. Pre-made tailwindCSS components
6. Support for HTMX & SweetAlert for notifications

### Menu open
![dark sample](/Docs/sample-dark.jpg)
![dark sample](/Docs/sample-light.jpg)

### Menu closed
![dark sample](/Docs/sample-dark-2.jpg)
![dark sample](/Docs/sample-light-2.jpg)


## Configuration

### Git

Go to the .gitignore file and uncomment the section called "# Protected environment variables" to ignore .env files when you push your changes.

### Theme

I strongly suggest - if you are using VS22 - to download the "[Tailwind CSS VS2022 Editor Support](https://marketplace.visualstudio.com/items?itemName=TheronWang.TailwindCSSIntellisense)" extension. Not required but really useful for autocomplete.

You can customize the theme changing the values on wwwroot/css/style.css. The idea was to use exactly the same variable names for light and dark themes and despite afterwards the variable "dark" could be a lighter color than the "light" one.

So you should not be concerned so much for the semantics in this case. It's name mostly refers to the contrast between the colors. A combination of a text-extralight and bg-dark will mean that it will have the maximum contrast, whether the "extralight" value is darker than the "dark" one for an specific theme.

That alone simplifies the css classes, avoiding the need for "dark:" selectors from Tailwind.

### SweetAlert

The ExtendedController has a Notify() method that interacts with HTMX to show a notification on the response, without interfering with the return value.

It's also customizable with the theme, you have 4 variables corresponding with the 4 types of notification. You can change those colors on wwwroot/css/style.css as you see fit.

You can also customize the button classes for the notification on the Notification.cs. You will find an auto-destructable script that sets up the config. 

Feel free to extend or change the Notification.cs class to match your needs. Here you have the SweetAlert2 docs:

https://sweetalert2.github.io/

### Docker

The template is preconfigured with two services using Docker and docker-compose. It assumes you will use SQL Server as your Db, but you can really change it adding or removing based on your project needs.

I would also strongly suggest you change .env environment variables. It's pre-created so you don't have to remember how or where to create it.

**Note:** If you use docker-compose, take into account the docker-compose.override.yml required for VS22 if you make some changes on your services. Otherwise you might find yourself not understanding why the changes aren't being reflected or some compilation errors because it does not find a service with a certain name.


## Setup

To launch the project, first open a cmd window and run:

```
	npm run style:build
```

That will prepare TailwindCSS to watch your CSS changes.

To run docker-compose in Visual Studio 2022, right-click the solution and go to "Properties". There change the dropdown in the "Single Startup Project" to "docker-compose".

Make sure to have Docker Desktop installed. If you don't, here is there official link: https://www.docker.com/products/docker-desktop/

