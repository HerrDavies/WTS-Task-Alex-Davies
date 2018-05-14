var employeeVM = function (element) {

    // private variables
    let _employees = ko.observableArray([]);

    // public variables
    this.container = element;

    this.employees = ko.computed({
        read: function () {
            var arrEmployees = _employees();

            if (arrEmployees && arrEmployees.length > 0) {
                // has values
                return arrEmployees;
            } else {
                // return value to display loading graphics
                return ["loading", "loading", "loading", "loading", "loading", "loading"];
            }
        },
        write: function (newValues) {
            _employees(newValues);
        }
    });


    // bind to interface
    ko.applyBindings(this, this.container);

    this.employeeList_Get();
}

employeeVM.prototype.employeeList_Get = function () {

    // clear employee list
    this.employees([]);

    // grab employee data
    fetch("/api/employees/test")
        .then(function (response) {

            return response.json();

        }).then(function (json) {
            // adding slight timeout so loading graphics show briefly (for demo)
            setTimeout(function () {
            this.employees(json);
            }.bind(this), 500);

        }.bind(this));

}