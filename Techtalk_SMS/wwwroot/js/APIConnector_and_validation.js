const APIGetMethod = async (URl, Parameter) => {   
    var Response;
    try {
        await $.ajax({
            type: 'GET',
            url: URl,
            contentType: "application/json",
            data: Parameter,
            async: false,
            headers: {
                Authorization: 'Bearer ' + $('#txttoken').val()
            },
            success: function (data) {
                Response = data
            }
        });
    }
    catch (err) {
        await console.log(err);
    }
    return Response;
}

const APIPostMethod = async (URl, Parameter) => {  
    var Response;
    try {
        await $.ajax({
            type: 'POST',
            url: URl,
            contentType: "application/json",
            data: JSON.stringify(Parameter),
            async: false,
            headers: {
                Authorization: 'Bearer ' + $('#txttoken').val()
            },
            success: function (data) {
                Response = data;               
            }
        });
        return Response;
    }
    catch (err) {
        await console.log(err);
    }
}

const APIPutMethod = async (URl, Parameter) => {
    var Response;
    try {
        await $.ajax({
            type: 'PUT',
            url: URl,
            contentType: "application/json",
            data: JSON.stringify(Parameter),
            async: false,
            headers: {
                Authorization: 'Bearer ' + $('#txttoken').val()
            },
            success: function (data) {
                Response = data; 
            }
        });
        return Response;
    }
    catch (err) {
        await console.log(err);
    }
}

const APIDeleteMethod = async (URl, Parameter) => {
    var Response;
    try {
        await $.ajax({
            type: 'DELETE',
            url: URl,
            contentType: "application/json",
            data: JSON.stringify(Parameter),
            headers: {
                Authorization: 'Bearer ' + $('#txttoken').val()
            },
            success: function (data) {
                Response = data;    
            }
        });
        return Response;
    }
    catch (err) {
        await console.log(err);
    }
}


const GetMethod = async (URl, Parameter) => {
    var Response;
    try {
        await $.ajax({
            type: 'GET',
            url: URl,
            contentType: "application/json",
            data: Parameter,
            async: false,
            success: function (data) {
                Response = data
            }
        });
    }
    catch (err) {
        await console.log(err);
    }
    return Response;
}
