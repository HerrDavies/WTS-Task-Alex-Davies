# WTS Task - Alex Davies
Some steps I would take as this project grew:

### Entities
Moving forward I would use a well defined structure for the entities to ensure the project did not become unwieldy. To increase security and obfuscate database structure, I would ensure the use of one set of objects when reading/writing from the database, and another set to return from publicly accessible API's over the network.

### Testing


### Data Persistence
To ensure the modularity of the codebase used to access the data source, I would include a Dependency Injection library to take control of the bindings against Interfaces. This would allow for multiple repository types and reduce the work required to swap out technologies in future.

### Javascript/Styling
All this small application needed to be able to do in the Javascript area was a small amount of DOM access and some Ajax. So instead of just including jQuery by default in the project (with all of its bloat), I used Vanilla Javascript and the new 'Fetch' API. I included a polyfill to be backwards compatible with older browsers lacking the API.

For styling I included FontAwesome for icons

To allow the Javascript and SASS in the project to be scalable and highly modular, I would use NodeJS and Gulp/Grunt to transpile Typescript and SASS, and then use an AMD library for loading scripts, or should there be a single page application, use something like Webpack to bundle everything.