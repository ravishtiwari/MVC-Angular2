﻿import { Component } from '@angular/core';

@Component({
    selector: 'createorder-app',
    template: `

<form action="/Orders/Create" id="CustomerForm" method="post"><input name="__RequestVerificationToken" type="hidden" value="e44ZmZ2TDUt182ASVf6A3S4BkiCy7yg3Q8URaj2_PVfiFfoJucMlJeRwVAucS73CgKrEkquGxLYqwBcLyh3X1TV7gWVs_3utbFMdVRY1dpw1" />    <div class="form-horizontal">
        <h4>Create Order</h4>
        <hr />
        
        <div class="form-group">
            <label class="control-label col-md-2" for="CustomerID">CustomerID</label>
            <div class="col-md-10">
                <select class="form-control" id="CustomerID" name="CustomerID"><option value="1">Real State Company</option>
<option value="2">Travel Agency</option>
</select>
                <span class="field-validation-valid text-danger" data-valmsg-for="CustomerID" data-valmsg-replace="true"></span>
            </div>
        </div>

        <div class="form-group">
            <label class="control-label col-md-2" for="OrderDate">OrderDate</label>
            <div class="col-md-10">
                <input class="form-control text-box single-line" data-val="true" data-val-date="The field OrderDate must be a date." data-val-required="The OrderDate field is required." id="OrderDate" name="OrderDate" type="datetime" value="" />
                <span class="field-validation-valid text-danger" data-valmsg-for="OrderDate" data-valmsg-replace="true"></span>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="CreateOrder" class="btn btn-default" />
            </div>
        </div>
    </div>
</form>
`,
})
export class CreateOrder { name = 'Angular'; }
