var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require("@angular/core");
var CreateOrder = (function () {
    function CreateOrder() {
        this.name = 'Angular';
    }
    return CreateOrder;
}());
CreateOrder = __decorate([
    core_1.Component({
        selector: 'createorder-app',
        template: "\n\n<form action=\"/Orders/Create\" id=\"CustomerForm\" method=\"post\"><input name=\"__RequestVerificationToken\" type=\"hidden\" value=\"e44ZmZ2TDUt182ASVf6A3S4BkiCy7yg3Q8URaj2_PVfiFfoJucMlJeRwVAucS73CgKrEkquGxLYqwBcLyh3X1TV7gWVs_3utbFMdVRY1dpw1\" />    <div class=\"form-horizontal\">\n        <h4>Create Order</h4>\n        <hr />\n        \n        <div class=\"form-group\">\n            <label class=\"control-label col-md-2\" for=\"CustomerID\">CustomerID</label>\n            <div class=\"col-md-10\">\n                <select class=\"form-control\" id=\"CustomerID\" name=\"CustomerID\"><option value=\"1\">Real State Company</option>\n<option value=\"2\">Travel Agency</option>\n</select>\n                <span class=\"field-validation-valid text-danger\" data-valmsg-for=\"CustomerID\" data-valmsg-replace=\"true\"></span>\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <label class=\"control-label col-md-2\" for=\"OrderDate\">OrderDate</label>\n            <div class=\"col-md-10\">\n                <input class=\"form-control text-box single-line\" data-val=\"true\" data-val-date=\"The field OrderDate must be a date.\" data-val-required=\"The OrderDate field is required.\" id=\"OrderDate\" name=\"OrderDate\" type=\"datetime\" value=\"\" />\n                <span class=\"field-validation-valid text-danger\" data-valmsg-for=\"OrderDate\" data-valmsg-replace=\"true\"></span>\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-10\">\n                <input type=\"submit\" value=\"CreateOrder\" class=\"btn btn-default\" />\n            </div>\n        </div>\n    </div>\n</form>\n",
    })
], CreateOrder);
exports.CreateOrder = CreateOrder;
//# sourceMappingURL=app.createordercomponent.js.map