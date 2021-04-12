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