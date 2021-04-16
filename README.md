# Crowd-CTRL

![Badge](https://badgen.net/badge/build/passing/green)

## Table of Contents

- [Contributors](#contributors)
- [Installation and Deployment](#install)
- [Walkthrough](#walkthrough)

## Contributors

*	Daniel Artuso (30029826)
*	Haohu Shen (30063099)
*	Kevin Sunkwa-Mills (30073036)
*	Teodor Tebeica (30046038)

## Installation and Deployment



The project is tested on multiple operating systems, including Windows, macOS and Linux. In order to run the app, the quickest way is to go to [Github Pages](https://dartuso.github.io/Crowd-CTRL) where the project is already deployed, or you can follow the instructions below to run the app locally:

*	Install  **.NET5.0 SDK** is required before running, you can visit [Download .NET](https://dotnet.microsoft.com/download) for further information.

*	After that, please run the instructions below in a terminal:

	```sh
	git clone https://github.com/dartuso/Crowd-CTRL.git
	cd Crowd-CTRL
	dotnet watch run
	```

*	Wait for several seconds until a notice in the terminal appears saying that *http://localhost:5000* is being listened to, and you can access this address in any modern browser to start using the app. If it fails to run, please check if the port 5000 is occupied by another process.

## Walkthrough

Here we list functions and the data needed to be entered on different web pages in our app, starting from the index page as a walkthrough:

<hr/>

### Location

Pages/Index.razor

### Functions

*	The user can login or sign up by pressing the corresponding button.

<hr/>

### Location

Pages/Login.razor

### Functions

*	To login, enter the correct username and the password and press **Login**. (the username is shown on the profile)

*	To register a new account, press **Sign Up**.

*	To recover the account if the user forgets the password, press **Password Recovery**. (this feature has not been implemented yet)

<hr/>

### Location

Pages/SignUp.razor

### Functions

*	To sign up, the user must enter its username, password and the email in text fields and then press the **Register**, notice that the email is not optional.

*	If the user wants to abandon the registration, just press **Back** and the user will be redirected to the login page.

<hr/>

### Location

Pages/AccountValidation.razor

### Functions

*	To finish the last step of registration, the user has to enter the verification code that sent to the email and press **Validate**.

*	If the user is not able to accept the verification code, he can press **Resend** to make the app resend the code again.

<hr/>

### Location

Pages/Profile-settings.razor

### Functions

*	This page can be accessible from sign up the setting button on top bar.

*	The user can customize profile with any values desired in username, bio, platforms and games including changing the profile.

	*	To change the profile's picture, press **change the profile picture**, and a random new profile picture will be shown.
	
	*	To change the username, enter the new username in the textbox and press **Update username**.

	*	To change the bio, enter the new bio in the textbox and press **Update Bio**.
	
	*	To connect your account in different gaming platforms, select the corresponding textbox, enter your username in that platform and press **Update platforms**.'

	*	To add a game to the list of current games in the app, enter the game's name in the textbox below **Manage your games** and press **Add Game**.

	*	To delete a game in the list of current games, click the game. (Bug - may require multiple clicks to delete)

	*	To update the password, enter the current password, new password, re-enter the new password and press **Update password**.

<hr/>

### Location

Pages/Profile.razor

### Functions

*	The page can be accessible by clicking the **profile** icon on the top bar.

*	The page shows the information of the username, bio, current games and current accounts in other platforms connected to the user, the user can change the information in the **Settings** page.

<hr/>

### Location

Pages/Home.razor

### Functions

*	The page can be accessible by clicking the **CC** icon in the middle of the top bar.

*	The user is able to browse posts by users and himself by scrolling.

*	The user can add reactions to posts by clicking fire emoji.

*	The user can add comments by clicking the comment button next to fire emoji.

*	The user can post stuff by writing in the textbox and press **Submit**, meanwhile, the user is able to upload a file by clicking the **Choose File**. For example, the user can upload a video and the video will be embedded in the post.

	*	The app will check if the content in the textbox is empty when the button is clicked.

<hr/>

### Location

Pages/Friends.razor

### Functions

#### Search Friends

*	The user is able to search any name in the textbox and will return a friend with a name.

*	The user is able to add searched friends with request friends.

*	The user is able to view a new friend profile by navigating to the previous page or via sidebar by updating it by clicking on a different friend.

*	When the user searches a friend, 3 pre-generated friends will be shown in the list based on past games played and common friends.

*	The user can go back to the friends' list from the result set by clicking the left arrow on the left of the search bar.

#### My Friends

*	In order to see a friend's profile, the user can click on a friend's name.

*	In order to chat with a friend, the user can click on the chat icon, which will open a chat box.

	*	The user is able to type a message and the current system will respond once.

	*	The user can minimize the chat box by clicking the arrow on the top-right corner.

		*	Once the chat box is minimized, the user can restore its size by clicking the name in the minimized box.

		*	The user can close the minimized chat box by clicking the red cross.

	*	The user can close the chat box by clicking the cross on the top-right corner.

*	The user can mute/unmute a friend by clicking the bell button.

*	In order to remove a friend, the user can click the red cross, and a modal will pop up for confirmation.

	*	To abandon the friend deletion, the user can click the **No** button.

	*	To remove the friend, the user can click the **Yes** button. (no friends will be removed in the simulation since we have not implemented it yet)

<hr/>

### Location

*	Components/FriendSidebar.razor
*	Program.cs

### Functions

There is a sidebar on the right of the window which contains the friends of the user, such that

*	The user can click a friend to check its profile.

*	The user can check a friend's status, including online/offline, which game he is playing.

Notice the data in friends profiles is randomly generated in the simulation.

<hr/>

### Location

*	Pages/Tournament.razor

### Functions


*	The page can be accessible by clicking on the tournament button on the top bar.

*	The user can view four recent tournaments.

	*	The user can view the bracket of a tournament by clicking the 'View bracket' button.

		*	The user can click the 'Go back' button to return to the tournament's page.
		
		*	The user can click the 'Share bracket' button to share the tournament's bracket. (this is not implemented yet)

*	In order to create a tournament, the user can press the **CREATE** button.

*	In order to join a tournament, the user can press the **JOIN** button. (this is not implemented yet)

<hr/>

### Location

*	Pages/TournamentCreate.razor

### Functions

*	The page can be accessible by clicking the **CREATE** button on the tournament's page.

*	The user can create a tournament by

	*	typing the tournament's name

	*	typing the tournament's game

	*	choosing the number of teams in the tournament

	*	typing the rules of the tournament
	
	* 	press **Continue** to create teams

		*	by entering teams' names

		*	by inviting (which is not implemented yet)

		* 	or abandon by clicking the **Go back** button

		*	or confirm by clicking the **Continue** button

<hr/>

### Location

Pages/Clans.razor

### Functions

*	The page can be accessible by clicking the clan button on the tournament's page.

*	There are some pre-generated clans in the clan's list such that

	*	The user has not joined these clans yet.

	* 	The user can view the clan's name, game, the number of current online users, the number of total members in the clan.

	*  The user can send a request to join by pressing the button.

*	The user is able to search any name in the textbox and press the **Search** button, then the app will return a clan with such name.

*	The user is able to create a new clan by clicking the **New Clan** button.

<hr/>

### Location

Pages/ClanCreation.razor

### Functions

*	The page can be accessible by clicking the **New Clan** button on the clan's page.

*	The user can upload fake avatar of the clan by clicking the **AVATAR**

*	The user can enter the clan's name, size, game, tag, short intro in the corresponding textbox.

*	The user can check if the value in the textbox is valid by clicking the corresponding **Checking** button and a modal will popup to indicate if it is valid or invalid.

*	To create the clan after typing all information, the user can press the **Create** button. (A modal will popup for confirmation, but no real clans will be created in the simulation.

<hr/>

### Location

*	Pages/ClanChatroom.razor
*  Components/ClanMembersSidebar.razor

### Functions

*	The page can be accessible by clicking the clan **Wutang Squad** on the right sidebar.

*	The user can read simulated chat messages by fake other users.

*	The user can type a message and click the **SEND** button to send it to the chat box (scroll down), a timestamp will be shown on the top of the message sent.

*  The user can view the simulated clan members and their status on the right.

*	The user can press the **Document** icon the top-right of the chatbox to view the details of the current clan.

*	The user can press the **Exit** icon the top-right of the chatbox to leave the clan, then a modal window will pop up for confirmation. If the user confirms to leave the clan, he will be redirected to the homepage.

<hr/>

### Location

Pages/ClanInfoCheck.razor

### Functions

*	The page can be accessible by clicking the **Document** icon inside the chatroom of the clan 'Wutang Squad' on the right sidebar.

*	The user can view the clan's name, size, tag, game and all current clan members including their status in the page.

<hr/>

### Location

Components/ClanSidebar.razor

### Functions

*	The user can view the list of clans he has joined, as well as the clan's name, the number of the clan's current online members, the number of the clan's total members on the right side-bar.

<hr/>

### Location

Pages/Notifications.razor

### Functions

*	The page can be accessible by clicking on the notification button on the top bar.

*	The user can view different types of notifications by different colors of the boundary box.

*	The buttons in the notifications are not working currently.

<hr/>

### Location

Components/CrowdHeader.razor

### Functions

*	The user can logout the app by clicking the logout button on the top bar, which will redirect the user to the login screen.