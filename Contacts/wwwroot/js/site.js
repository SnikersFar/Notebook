$(document).ready(function () {
    let WindowTitle = $(".WindowTitleText");
    let InputId = $("#Id");
    let InputName = $("#InputNamePlace");
    let InputMobilePhone = $("#InputMobilePhonePlace");
    let InputJob = $("#InputJobTitlePlace");
    let InputBirthDay = $("#InputBirthDayPlace");
    let SaveButton = $("#InputWindowSaveButton");

    

    $(".addButton").click(function () {
        WindowTitle.html("Add Contact");
        InputId.attr('value', '0');
        InputName.attr('value', '');
        InputMobilePhone.attr('value', '');
        InputJob.attr('value', '');
        InputBirthDay.attr('value', '');
        SaveButton.attr('value', "Add")
    });

    $(".EditButton").click(function () {
        let MyId = $(this).attr("Id");
        WindowTitle.html("Change Contact");
        InputId.attr('value', MyId);
        InputName.attr('value', $("#Name-" + MyId).text());
        InputMobilePhone.attr('value', $("#MobilePhone-" + MyId).text());
        InputJob.attr('value', $("#JobTitle-" + MyId).text());

        let StringDate = $("#BirthDay-" + MyId).text().split(".")
        let date = new Date();
        date = StringDate[2] + "-" + StringDate[1] + "-" + StringDate[0];
        InputBirthDay.attr('value', date);
        SaveButton.attr('value', "Change");
    });
    $('body').on('input', '#InputMobilePhonePlace', function () {
        this.value = this.value.replace(/[^0-9]/g, '');
        if (this.value.length > 15) {
            this.value = this.value.slice(0, 15);
        }
    });

    $('body').on('input', '#InputNamePlace', function () {
        if (this.value.length > 30) {
            this.value = this.value.slice(0, 30);
        }
    });


    SaveButton.click(function () {
        InputMobilePhone.value = InputMobilePhone.value.replace(/[^0-9]/g, '');
        if (InputMobilePhone.value.length > 15) {
            InputMobilePhone.value = InputMobilePhone.value.slice(0, 15);
        }
        if (InputName.value.length > 30) {
            InputName.value = InputName.value.slice(0, 30);
        }
    });

 

});