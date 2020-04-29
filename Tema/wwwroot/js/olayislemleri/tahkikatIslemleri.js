const tahkikatTasarim1 = document.getElementById("tahkikatTasarim1");
const tahkikatTasarim2 = document.getElementById("tahkikatTasarim2");



tahkikatTasarim1.addEventListener("click", function() {
    $("#tahkikatTasarim1_view").show();
    $("#tahkikatTasarim2_view").hide();


});

tahkikatTasarim2.addEventListener("click", function() {

    $("#tahkikatTasarim1_view").hide();
    $("#tahkikatTasarim2_view").show();

});

const B_olayYeriTesbitTutatagi = document.getElementById("B_olayYeriTesbitTutatagi");
const B_ifadeAlmaIslemleri = document.getElementById("B_ifadeAlmaIslemleri");
const B_aileIciSiddetOlaylari = document.getElementById("B_aileIciSiddetOlaylari");
const B_savciGorusmeTutanagi = document.getElementById("B_savciGorusmeTutanagi");
const B_degerTesbitTutatagi = document.getElementById("B_degerTesbitTutatagi");

B_olayYeriTesbitTutatagi.addEventListener("click", function() {
    $("#olayYeriTesbitTutatagi_view").show();
    $("#ifadeAlmaIslemleri_view").hide();
    $("#aileIciSiddetOlaylari_view").hide();
    $("#savciGorusmeTutanagi_view").hide();
    $("#degerTesbitTutatagi_view").hide();
});

B_ifadeAlmaIslemleri.addEventListener("click", function() {
    $("#olayYeriTesbitTutatagi_view").hide();
    $("#ifadeAlmaIslemleri_view").show();
    $("#aileIciSiddetOlaylari_view").hide();
    $("#savciGorusmeTutanagi_view").hide();
    $("#degerTesbitTutatagi_view").hide();
});

B_aileIciSiddetOlaylari.addEventListener("click", function() {
    $("#olayYeriTesbitTutatagi_view").hide();
    $("#ifadeAlmaIslemleri_view").hide();
    $("#aileIciSiddetOlaylari_view").show();
    $("#savciGorusmeTutanagi_view").hide();
    $("#degerTesbitTutatagi_view").hide();
});

B_savciGorusmeTutanagi.addEventListener("click", function() {
    $("#olayYeriTesbitTutatagi_view").hide();
    $("#ifadeAlmaIslemleri_view").hide();
    $("#aileIciSiddetOlaylari_view").hide();
    $("#savciGorusmeTutanagi_view").show();
    $("#degerTesbitTutatagi_view").hide();
});

B_degerTesbitTutatagi.addEventListener("click", function() {
    $("#olayYeriTesbitTutatagi_view").hide();
    $("#ifadeAlmaIslemleri_view").hide();
    $("#aileIciSiddetOlaylari_view").hide();
    $("#savciGorusmeTutanagi_view").hide();
    $("#degerTesbitTutatagi_view").show();
});