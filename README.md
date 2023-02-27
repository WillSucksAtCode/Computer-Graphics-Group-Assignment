# Computer Graphics Group Assignment

William Heath - 100829482 - Created the Repo, Video, Bloom effect, and decals.

Farhan Hussain - 100787821 - Created Particles, and Motion Blur.

Rim Lighting and Toon Ramp were created with shader graph's to work with URP Rim lighting was created using the Fresnel Effect Node combined with a Color Node Toon ramp was created with the help of this tutorial: https://www.youtube.com/watch?v=FIP6I1x6lMA
Decals were created with the help of this tutorial: https://www.youtube.com/watch?v=P4HwA-O9vB4

Game Build: https://willidev.itch.io/viral-destruction-group-assignment (Too big for Git)

Slide Video:https://youtu.be/XNeQQWMHPHE

Video Demo: [https://youtu.be/LAgPfSIDIG0](https://youtu.be/A0AwlYKQ_6Q)

Slide Deck: https://docs.google.com/presentation/d/1qWbUSUVjijJ5278fTo5lUFFhR3mjFw8-BowExzcLLgA/edit?usp=sharing

Video Transcript: Hello Everybody, my name is William, and I will be doing a video for our group project.
Here are our names, student numbers and pictures.

In this project, we will be covering what our game is as well as what carried over from our individual assignments, our visual effects which are Decals and particle effects, and then our post processing effects, which are bloom and motion blur.

So, our game Viral Destruction is a First-Person Shooter where you explore an infected facility in hopes to reach the bottom and stop the infection. The player has basic FPS movement with three different weapon types to choose from. In the provided level, your goal is to reach the end of the forest and get to the facility, taking down enemies and scavenging for ammo along the way.

Here is a Video demonstration of all of our implementations.

From our Individual Assignments, we implemented Toon Ramp, Rim lighting, and Bump Mapping. Toon ramp has been applied to the enemies for more visual flare in the standard render pipeline, Toon ramp is achieved by getting the dot product between the normal of the surface and the direction of the light, and then multiplying that value by 0.5 and add 0.5, and use that value along with our ramp texture gives us the look that toon ramp has. The final value  can be anything from 0-1 and is used to pick which shade of the ramp texture that specific normal should use. This had to be altered to work with Unitys render pipeline.

Bump mapping basically distorts the normals of an object using a special texture to alter the lighting and give the illusion of more detail without actually modeling it.

Rim lighting is done by getting the view direction of the user, and then getting the dot product of the that and the normal of the object, saturating it, and subtracting that value by 1. You can then modify this with color or an intensity float.

Finally, we got stuck during our attempt to implement look up tables, though the code and tables are still present, we did attempt to add them using post processing, but were unsuccessful.

Anyways, continuing onto visuals effects, I added decals to our game. I created a bloody hand texture to add to the facility wall to give a more ominous feeling to our game. Decals are done by layering an extra texture on top of an already existing object. We do this by getting two textures and then applying the decal texture in the surf function using the albedo. It Unity’s render pipeline, we implement it using a decal material on a decal projector.

Farhan created particles for the guns as well as rain using unity’s particle system. The rain particles loop and are released in a square shape around the player. He then chose "random between two constants" in the linear section of velocity of its lifetime. The constants' values were only changed in the Y-axis to -25, and -35 so that we have different variations to how it falls. Gun particles were done with a standard cone emission and were slightly modified for each gun to fit their firing styles.

Moving on to post processing effects, I implemented Bloom into our game and used it in the outdoor level to give a sense of moonlight reflecting off of the enemies. Bloom is achieved by blurring the view of the camera, brightening that and then adding it to the original view, and that can be achieved with the blend mode One one. In Unity’s rendering pipeline its is simply done using the post processing effect of the same name, with the addition of a subtle blue tint.

Finally, Farhan added motion blur to add some realism to our game. Motion blur is the process of blurring the player's view in the direction of movement. It basically gets the frames over a set amount of time and blends them together to get a blur effect. It was implemented using the post processing motion blur effect in unitys render pipeline.

Anyways thats all we have for you for today, thank you for watching.

