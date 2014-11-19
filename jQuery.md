###### Find server side control in jQuery
`$('[id$=lblWishList]')`

###### Find element with data attribute
`('#grid [data-id="26"]')`

###### Fill Dropdown using JSON
function fillZone() {  
            
            var ddlZone = $('#ddlZone');
            ddlZone.empty();
            ddlZone.append(
                    $('<option/>', {
                        value: '0',
                        html: '----- Select -----'
                    })
                );
            $.each(<%= ZoneJSON %>, function () {
                ddlZone.append(
                    $('<option/>', {
                        value: this.SiteID,
                        html: this.SiteName
                    })
                );
            });

        }
