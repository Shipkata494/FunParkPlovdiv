const smallEditBtn = document.getElementById("small-course");
smallEditBtn.addEventListener("click", EditSmallCourse);
const BigEditBtn = document.getElementById("big-course");
BigEditBtn.addEventListener("click", EditBigCourse);
const uploadImageBtn = document.getElementById("uploadImages");
uploadImageBtn.addEventListener("click", uploadImage);
function EditSmallCourse() {


    let form = document.createElement("form");
    form.action = "Price/EditSmallCourse";
    form.method = "post";
    let titleDiv = document.createElement("div");
    titleDiv.className = "form-group";
    let titleLabel = document.createElement("label");
    const smallCourseTitle = document.getElementById("SmallCourseTitle").textContent;
    titleLabel.htmlFor = "Title";
    titleLabel.innerText = "Title";
    let titleInput = document.createElement("input");
    titleInput.className = "form-control";
    titleInput.id = "Title";
    titleInput.name = "Title";
    titleInput.value = smallCourseTitle;
    titleInput.required = true;
    titleDiv.appendChild(titleLabel);
    titleDiv.appendChild(titleInput);

    const smallCourseValue = document.getElementById("SmallCourseValue").textContent.slice(0,5);
    let valueDiv = document.createElement("div");
    valueDiv.className = "form-group";
    let valueLabel = document.createElement("label");
    valueLabel.htmlFor = "Value";
    valueLabel.innerText = "Value";
    let valueInput = document.createElement("input");
    valueInput.type = "text";
    valueInput.className = "form-control";
    valueInput.id = "Value";
    valueInput.value = smallCourseValue;
    valueInput.name = "Value";
    valueInput.required = true;
    valueDiv.appendChild(valueLabel);
    valueDiv.appendChild(valueInput);

    let submitButton = document.createElement("button");
    submitButton.type = "submit";
    submitButton.className = "btn btn-primary";
    submitButton.innerText = "Submit";

    form.appendChild(titleDiv);
    form.appendChild(valueDiv);
    form.appendChild(submitButton);

  
   
    let container = document.getElementById("dynamicFormContainer");
    container.innerHTML = '';
    container.appendChild(form);
}
function EditBigCourse() {

    let form = document.createElement("form");
    form.action = "Price/EditBigCourse"
    form.method = "post";
    let titleDiv = document.createElement("div");
    titleDiv.className = "form-group";
    let titleLabel = document.createElement("label");
    titleLabel.htmlFor = "Title";
    titleLabel.innerText = "Title";
    let titleInput = document.createElement("input");

    const bigCourseTitle = document.getElementById("BigCourseTitle").textContent;
    titleInput.className = "form-control";
    titleInput.id = "Title";
    titleInput.name = "Title";
    titleInput.value = bigCourseTitle;
    titleInput.required = true;
    titleDiv.appendChild(titleLabel);
    titleDiv.appendChild(titleInput);

    const bigCourseValue = document.getElementById("BigCourseValue").textContent.slice(0, 5);
    let valueDiv = document.createElement("div");
    valueDiv.className = "form-group";
    let valueLabel = document.createElement("label");
    valueLabel.htmlFor = "Value";
    valueLabel.innerText = "Value";
    let valueInput = document.createElement("input");
    valueInput.type = "text";
    valueInput.className = "form-control";
    valueInput.id = "Value";
    valueInput.name = "Value";
    valueInput.value = bigCourseValue;
    valueInput.required = true;
    valueDiv.appendChild(valueLabel);
    valueDiv.appendChild(valueInput);

    let submitButton = document.createElement("button");
    submitButton.type = "submit";
    submitButton.className = "btn btn-primary";
    submitButton.innerText = "Submit";

    form.appendChild(titleDiv);
    form.appendChild(valueDiv);
    form.appendChild(submitButton);

    let container = document.getElementById("dynamicFormContainer");
    container.innerHTML = '';
    container.appendChild(form);
}
function uploadImage() {
    var formData = new FormData();
    var fileInput = document.getElementById('imageFile');
    formData.append('imageFile', fileInput.files[0]);
    
    fetch('/Image/Upload', {
        method: 'POST',
        body: formData
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json();
        })
        .then(data => {
            console.log(data);         
        })
        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });
}