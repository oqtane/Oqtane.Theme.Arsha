# Oqtane.Theme.Arsha

An Oqtane theme developed for Oqtane 5.1 using Static Server-Side Rendering and based on the BootstrapMade Arsha template (https://bootstrapmade.com/arsha-free-bootstrap-html-template-corporate/).

Screen capture of the theme functionality is included below:
https://github.com/oqtane/Oqtane.Theme.Arsha/assets/4840590/2a548fbb-6a0b-492a-8a9a-9c3c4f9b6819

Notice how the theme preserves both the appearance of the BootstrapMade template as well as the animations.

In order to reproduce the behavior in the video, clone this repo, open the solution in Visual Studio 2022 and perform a Build. Once the solution has been built you can set the Oqtane.Server as the Startup project and run it. Then you can navigate to Site Settings and choose the Arsha theme in the Appearance section. This will refresh the page and the site will have a new appearance. Note that the theme has a default display which works with Admin pages, etc... The footer content is the same throughout the site and can be modified through the user interface (explanation below).

Navigate to the Home page. Use the Control Panel to choose the Edit Page option. Choose the Theme Settings tab:

![image](https://github.com/oqtane/Oqtane.Theme.Arsha/assets/4840590/81684415-93df-4b2d-af66-b9cc5aa90e76)

You will notice that there are 2 options: Hero HTML and Footer HTML. The Footer HTML will be populated by default and you can modify the content to match your own content, address, links, etc... however leave the HTML markup intact to preserve the CSS styles, etc... 

The Home page has a "hero" section where it displays a large banner. You can enable this by selecting the Load Default Hero HTML button... it will load the HTML markup which can be modified based on your preference. 

Click Save to accept your changes. 

Now you will want to replace the content of the Html/Text module on the page. If you have more than 1 Html/Text module remove the others. Select Edit Mode and access the Action Menu for the module and choose Manage Settings. Change the Title to "-" and Save - this will hide the title of the module. 

Now find the Edit button for the Html/Text module and select it. Choose the Raw HTML tab, as the Rich Text editor will not be able to support the content you need to include. Find the content.txt file in the root folder of this project (same folder as the solution file). Open the text file and copy and paste its contents into the Raw HTML editor and then Save. The page will be redisplayed and should look exactly the way it does in the video capture above.

Note that you can open the Html/Text module again (and choose the Raw HTML editor tab as the Rich Text editor will be blank). You can remove specific ```<section>``` blocks if you want to exclude some of the template content. Or you can copy and paste sections if you want multiple sections - but only change the content, never the HTML markup if you want to preserve the appearance of the page.

One large benefit of the BootstrapMade templates is that they are fully responsive and work well in all screen sizes, so you do not need to worry about understanding CSS.

Also note that although the BootstrapMade templates can be downloaded for free, you need to purchase a license for $19 in order to use it on a business website.





