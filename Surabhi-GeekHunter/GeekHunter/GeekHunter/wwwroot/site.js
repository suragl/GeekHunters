const candidateApiUri = "api/candidates";
const skillApiUri = "api/skill";
let skills = null;

$(document).ready(function () {
    getSkills();
    getData(0);
});

function getSkills() {

    $.ajax({
        type: "GET",
        url: skillApiUri,
        cache: false,
        success: function (data) {
            skills = data;

            $.each(skills, function (i, item) {
                $("#add-skills").append($('<option>', {
                    value: item.id,
                    text: item.name
                }));

                $("#filter-skills").append($('<option>', {
                    value: item.id,
                    text: item.name
                }));

            });
        }
    });

}


$( "#filter-skills" ).change(function() {
    getData($("#filter-skills").val());

});


function getData(skillId) {

    const item = {
        skillId: skillId 
    };

    $.ajax({
        type: "GET",
        url: candidateApiUri,
        cache: false,
        data: item,
        success: function (data) {
            const tBody = $("#candidateTable");

            $(tBody).empty();

            $.each(data, function (key, item) {
                const tr = $("<tr></tr>")
                    .append($("<td></td>").text(item.firstName))
                    .append($("<td></td>").text(item.lastName))
                    .append($("<td></td>").text(getValuesStringOfSkills(item.skillIds)));

                tr.appendTo(tBody);
            });
        }
    });
}

function getValuesStringOfSkills(skillIds) {
    values = [];
    $.each(skillIds, function (i, skillId) {

        $.each(skills, function (j, item) {
            if (item.id == skillId) {
                values.push(item.name);   
            }
        });
    });

    return values;
}


function addItem() {

    const item = {
        firstName: $("#add-firstName").val(),
        lastName: $("#add-lastName").val(),
        skillIds: $("#add-skills").val(),
        
    };

    $.ajax({
        type: "POST",
        accepts: "application/json",
        url: candidateApiUri,
        contentType: "application/json",
        data: JSON.stringify(item),
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Something went wrong!");
        },
        success: function (result) {
            getData(0);
            $("#add-firstName").val("");
            $("#add-lastName").val("");
            $("#add-skills").val("");
            $("#filter-skills").val(0).change();
        }
    });
}


