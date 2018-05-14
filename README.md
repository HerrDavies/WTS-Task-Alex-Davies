# WTS Task - Alex Davies

Some reasoning and future changes for this project:

### Entities
---
Moving forward I would use a well defined structure for the entities to ensure the project did not become unwieldy. To increase security and obfuscate database structure, I would ensure the use of one set of objects when reading/writing from the database, and another set to return from publicly accessible API's over the network.

### Testing
---
The unit tests for the project all live in the tests folder, as I like to keep tests together, and then use their target namespaces to identify them.

### Data Persistence
---
To ensure the modularity of the codebase used to access the data source, I would include a Dependency Injection library to take control of the bindings. This would allow for multiple repository types and reduce the work required to swap out technologies in future. The interfaces project implemented in the persistence folder could easily be extended to include extra functionality, and the Entity Framework project implements this interface. I used Entity Framework which maintains its own objects for read/write operations on the database, allowing me to convert to common objects used by the rest of the codebase.

I did not use the singleton pattern for the Entity Framework implementation due to possible performance issues surrounding the way it works (change tracking/committing etc).

### Javascript/Styling
---
Due to only needing to be able to do a small amount of DOM access and some Ajax calls, instead of just including jQuery by default in the project (with all of its bloat), I used Vanilla Javascript and the new 'Fetch' API. I included a polyfill to be backwards compatible with older browsers lacking the fetch functionality. I used KnockoutJS to bind the information to the interface.

For styling I included Twitter Bootstrap. Generally this includes a lot of bloat, so moving forward, either using a custom set of styling or a custom build of Bootstrap would be beneficial.

I used some CSS3 transitions to implement the loading graphics on the table. There is also a small arbitrary timeout in the Javascript which delays the display of the data so that the loading graphics are visible.

To allow the Javascript and SASS in the project to be scalable and highly modular, I would use NodeJS and Gulp/Grunt to transpile Typescript and SASS, and then use an AMD library for loading scripts, or should it be a single page application, use something like Webpack to bundle everything.