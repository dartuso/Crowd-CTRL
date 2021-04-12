
// Current clan lists
const clanList =
    ["Wutang Squad",
        "Apex Hunters",
        "H1Z1_E_lite_",
        "pubg_alphaSquad",
        "_LosSantos_Epic_",
        "Fall_guys",
        "Wh4ck4Gnome",
        "CCTechSupport",
        "FridaysLeagueGamers",
        "NeverOverOverwatch",
        "WDCamperPatrol",
        "ApexGamingTeam",
    ];

// Pop-out an alert window
function createAlert(s) {
    alert(s);
}

// Check if a string is null or empty
function isStringEmpty(str) {
    return (!str || str.length === 0);
}

// Check if a string is a number without leading zeroes
function isNumber(str) {
    var pattern = /^([1-9][0-9]*|0)$/;
    return pattern.test(str);  // returns a boolean
}

// Check if the number is between a and b
function isNumberValid(str, a, b) {
    for (let i = a; i <= b; ++i) {
        if (i.toString() === str) {
            return true;
        }
    }
    return false;
}

// Check if the clan name is valid
function clanNameCheck(id) {
    var s = document.getElementById(id);
    s.modal();
}

function clanNameCheck2(id) {
    var s = document.getElementById(id);
    if (isStringEmpty(s.value)) {
        s.value = "The clan name cannot be empty!";
    }
    else if (clanList.includes(s.value)) {
        s.value = "The clan name already exists!";
    }
}

// Check if size of the clan is valid
function clanSizeCheck(id) {
    var s = document.getElementById(id);
    var c = document.getElementById(id).style.color;
    if (isStringEmpty(s.value)) {
        s.value = "The size of the clan cannot be empty!";
        s.style.color = "red";
    }
    else if (!isNumber(s.value)) {
        alert("The size of the clan must be a integer!");
    }
    else if (!isNumberValid(s.value, 1, 100)) {
        alert("The size of the clan cannot be larger than 100 or smaller than 1!");
    }
    else {
        alert("The size of the clan is valid!");
    }
}

// Check if the clan game is valid
function clanGameCheck(id) {
    if (isStringEmpty(document.getElementById(id).value)) {
        alert("The clan game cannot be empty!");
    } else {
        alert("The clan game is valid!");
    }
}

// Check if the clan tag is valid
function clanTagCheck(id) {
    if (isStringEmpty(document.getElementById(id).value)) {
        alert("The clan tag cannot be empty!");
    } else {
        alert("The clan tag is valid!");
    }
}

// Append the message sent by the user to the end of the unordered list
function appendMsg(inputBoxId, chatListId) {

    let inputTextArea = document.getElementById(inputBoxId);
    let textinput = inputTextArea.value;
    let li1 = document.createElement("li");

    // Get the current date
    let d = new Date();
    let day = ("0" + d.getDate()).slice(-2);
    let month = ("0" + (d.getMonth() + 1)).slice(-2);
    let datestring = month + "-" + day + "-" +
        d.getFullYear() + " " + ("0" + d.getHours()).slice(-2) + ":" + ("0" + d.getMinutes()).slice(-2);
    li1.innerHTML += `
                                            <div class="avatar">
                                                <div><img src="Avatars/dragon-stencil-silhouette-freesvg.org.svg" style="width:80px;" /></div>
                                            </div>
                                            <div class="chat-info">
                                                <div>
                                                    <div class="chat-info-name" style="color:rgb(82,128,255)">
                                                        Sinistra09
                                                    </div>
                                                    <div class="chat-info-date" style="color:gray">
                                                        `+ datestring + `
                                                    </div>
                                                </div>
                                                <div>
                                                    `+ textinput + `
                                                </div>
                                            </div>
                                        `
    document.getElementById(chatListId).appendChild(li1);
    // Clear the input box
    inputTextArea.value = "";
}

// Pop out a confirmation window to let the user choose if he wants to leave the clan
function leaveClanConfirmation() {
    let answer = window.confirm("Are you sure to leave the clan?");
    if (answer) {
        alert("Leave the clan successfully!");
    }
}