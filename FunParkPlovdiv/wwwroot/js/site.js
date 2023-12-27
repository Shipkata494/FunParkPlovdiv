const smallEditBtn = document.getElementById("small-course");
smallEditBtn.addEventListener("click", EditSmallCourse);
const BigEditBtn = document.getElementById("big-course");
BigEditBtn.addEventListener("click", EditBigCourse);
function EditSmallCourse(){
    var form = document.createElement("form");
    form.action = "Price/EditSmallCourse";
    form.method = "post";
    var titleDiv = document.createElement("div");
    titleDiv.className = "form-group";
    var titleLabel = document.createElement("label");
    const smallCourseTitle = document.getElementById("SmallCourseTitle").textContent;
    titleLabel.htmlFor = "Title";
    titleLabel.innerText = "Title";
    var titleInput = document.createElement("input");
    titleInput.className = "form-control";
    titleInput.id = "Title";
    titleInput.name = "Title";
    titleInput.value = smallCourseTitle;
    titleInput.required = true;
    titleDiv.appendChild(titleLabel);
    titleDiv.appendChild(titleInput);

    const smallCourseValue = document.getElementById("SmallCourseValue").textContent.slice(0,5);
    var valueDiv = document.createElement("div");
    valueDiv.className = "form-group";
    var valueLabel = document.createElement("label");
    valueLabel.htmlFor = "Value";
    valueLabel.innerText = "Value";
    var valueInput = document.createElement("input");
    valueInput.type = "text";
    valueInput.className = "form-control";
    valueInput.id = "Value";
    valueInput.value = smallCourseValue;
    valueInput.name = "Value";
    valueInput.required = true;
    valueDiv.appendChild(valueLabel);
    valueDiv.appendChild(valueInput);

    var submitButton = document.createElement("button");
    submitButton.type = "submit";
    submitButton.className = "btn btn-primary";
    submitButton.innerText = "Submit";

    form.appendChild(titleDiv);
    form.appendChild(valueDiv);
    form.appendChild(submitButton);

    var container = document.getElementById("dynamicFormContainer");
    container.innerHTML = '';
    container.appendChild(form);
}
function EditBigCourse() {
    var form = document.createElement("form");
    form.action = "Price/EditBigCourse"
    form.method = "post";
    var titleDiv = document.createElement("div");
    titleDiv.className = "form-group";
    var titleLabel = document.createElement("label");
    titleLabel.htmlFor = "Title";
    titleLabel.innerText = "Title";
    var titleInput = document.createElement("input");

    const bigCourseTitle = document.getElementById("BigCourseTitle").textContent;
    titleInput.className = "form-control";
    titleInput.id = "Title";
    titleInput.name = "Title";
    titleInput.value = bigCourseTitle;
    titleInput.required = true;
    titleDiv.appendChild(titleLabel);
    titleDiv.appendChild(titleInput);

    const bigCourseValue = document.getElementById("BigCourseValue").textContent.slice(0, 5);
    var valueDiv = document.createElement("div");
    valueDiv.className = "form-group";
    var valueLabel = document.createElement("label");
    valueLabel.htmlFor = "Value";
    valueLabel.innerText = "Value";
    var valueInput = document.createElement("input");
    valueInput.type = "text";
    valueInput.className = "form-control";
    valueInput.id = "Value";
    valueInput.name = "Value";
    valueInput.value = bigCourseValue;
    valueInput.required = true;
    valueDiv.appendChild(valueLabel);
    valueDiv.appendChild(valueInput);

    var submitButton = document.createElement("button");
    submitButton.type = "submit";
    submitButton.className = "btn btn-primary";
    submitButton.innerText = "Submit";

    form.appendChild(titleDiv);
    form.appendChild(valueDiv);
    form.appendChild(submitButton);

    var container = document.getElementById("dynamicFormContainer");
    container.innerHTML = '';
    container.appendChild(form);
}

