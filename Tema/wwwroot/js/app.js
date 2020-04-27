const tasarim1 = document.getElementById("tasarim1");
const tasarim2 = document.getElementById("tasarim2");
const tasarim3 = document.getElementById("tasarim3");


tasarim1.addEventListener("click", function () {
    $("#tasarim1_view").show();
    $("#tasarim2_view").hide();
    $("#tasarim3_view").hide();

});

tasarim2.addEventListener("click", function () {

    $("#tasarim1_view").hide();
    $("#tasarim2_view").show();
    $("#tasarim3_view").hide();
});

tasarim3.addEventListener("click", function () {
    $("#tasarim1_view").hide();
    $("#tasarim2_view").hide();
    $("#tasarim3_view").show();
});

$('#example1').DataTable({
    "language": {
        "url": "//cdn.datatables.net/plug-ins/1.10.12/i18n/Turkish.json"
    }
});

$('#example').DataTable({
    "language": {
        "url": "//cdn.datatables.net/plug-ins/1.10.12/i18n/Turkish.json"
    }
});


$('#example2').DataTable({
    "language": {
        "url": "//cdn.datatables.net/plug-ins/1.10.12/i18n/Turkish.json"
    }
});

