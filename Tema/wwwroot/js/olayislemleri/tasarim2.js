const kimligibelirlimadur = document.getElementById("kimligibelirlimadur");
const kimligibelirlisupheli = document.getElementById("kimligibelirlisupheli");
const kimligibelirlitanik = document.getElementById("kimligibelirlitanik");
const kimligimechulmagdurtanik = document.getElementById("kimligimechulmagdurtanik");
const tuzelkisilik = document.getElementById("tuzelkisilik");


kimligibelirlimadur.addEventListener("click", function () {
    $("#divkimligibelirlimadur").show();
    $("#divkimligibelirlisupheli").hide();
    $("#divkimligibelirlitanik").hide();
    $("#divkimligimechulmagdurtanik").hide();
    $("#divtuzelkisilik").hide();

});

kimligibelirlisupheli.addEventListener("click", function () {
    $("#divkimligibelirlimadur").hide();
    $("#divkimligibelirlisupheli").show();
    $("#divkimligibelirlitanik").hide();
    $("#divkimligimechulmagdurtanik").hide();
    $("#divtuzelkisilik").hide();
});

kimligibelirlitanik.addEventListener("click", function () {
    $("#divkimligibelirlimadur").hide();
    $("#divkimligibelirlisupheli").hide();
    $("#divkimligibelirlitanik").show();
    $("#divkimligimechulmagdurtanik").hide();
    $("#divtuzelkisilik").hide();
});

kimligimechulmagdurtanik.addEventListener("click", function () {
    $("#divkimligibelirlimadur").hide();
    $("#divkimligibelirlisupheli").hide();
    $("#divkimligibelirlitanik").hide();
    $("#divkimligimechulmagdurtanik").show();
    $("#divtuzelkisilik").hide();
});

tuzelkisilik.addEventListener("click", function () {
    $("#divkimligibelirlimadur").hide();
    $("#divkimligibelirlisupheli").hide();
    $("#divkimligibelirlitanik").hide();
    $("#divkimligimechulmagdurtanik").hide();
    $("#divtuzelkisilik").show();
});
