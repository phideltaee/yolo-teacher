# yolo-teacher
Main repository for the AR Language Teacher for the 3D vision class, spring 2020.

# Video of Working Solution
[insert link here]

# Working on this repo:

## Mac
- Navigate to your desired downloads directory. 
- Open the terminal and write `git clone github.com/phideltaee/yolo-teacher.git`

## Windows 
Clone this repository into a new folder. 

## Installation Guide
#### 1. Create a New unity Project 
Unity Version used for this solution: 2018.4.18f1

#### 2. Download OpenCV for Unity

#### 3. Import the package in your unity project
        Navigate to: Unity -> Assets -> Import Package -> Custom Package -> [Now browse to the directory where the OpenCV_for_Unity package was downloaded.]

#### 4. Follow the set-up instruction from the PDF

#### 5. Download the pacakge from this github [AR_language_teacher](https://github.com/phideltaee/yolo-teacher)

#### 6. Import the Package to your project


## User-guide
This project was developped with the aim of making use of Augmented Reality to learn a language. 
The unity solution is decomposed in three scenes: a main menu and two mini-games.
We will therefore explain to you their various functionalities and possible interactions 

### 1. Main menu 
The main menu is composed of two Buttons that enable the user to choose which mini-game we want to play for his learning.

### 2. Exploration mode 
Once the exploration mode start, the view of the camera from your mobile device is displayed on your screen. 
In the middle of the scree, a whithe cursor should appear. It will help you to point at the object from your environment that you want to know the translation. 
Then, on the right side of the screen, there area lists of 5 buttons to set the language of your choices and on top of this buttons list is a panel always showing you the translation in english of the last object in the room succesfuly identify.  
Finally, the table on the left side of your screen serves as a summary, and store all the words you have learned so far, with its translation in the five available languages.  


### 3. Word hunting mode
This mode is divided in to phases.
Fisrt of all, once the user is ready, he can press the button start scanning in the middle of the screen to start the first phase of the process. 

During 10 seconds the user will have to move its camera to detect at least three objects from his direct environmnet and complete the scanning phase. Once the 10 second are passe, if the scanning procedure is completed the user can start to hunt for the words detected by clicking the button start hunting. However, if the number of objects detected is insufficient, the user is asked to restart the scanning phase. 

When the hunt begin, the word to find is written in the box on the top left of the screen. In the same time, the timer is reset to 60 seconds which correspond to the time the user is given to find the object in the surrounding environment. when, the word is correctly detected, then it goes to the next words identify in the scene during the scanning phase. To win the game, the user has to correctly point at each word list build d 
To win the game, the user must find all the words scanned during the first phase within the allocated time.

Now you should have the basics you need to navigate freely in our applications. 
So, we wish you good luck and hope that will enrich your vocabulary while having fun   



# Troubleshooting
### GUI is not Properly Sized
[insert picture of this problem]


# References on github
https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository
