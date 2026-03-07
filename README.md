Adds the standard MacOS space bar shortcut to the Unity Editor Assets menu.

Sends the paths of any selected assets to the `qlmanage` app:

https://developer.apple.com/library/archive/documentation/UserExperience/Conceptual/Quicklook_Programming_Guide/Articles/QLDebugTest.html

`qlmanage -p /path/to/Unity/Project/Assets/triangle.fbx`

A complete bodge, as the `qlmanage` app was really only supplied to be used for debugging QuickLook extensions. But it works: you get a nice QuickLook-style preview window, even with multiple asset files selected.

(I’m not even sure if `qlmanage` comes as standard on MacOS, or if it’s only part of the extra installs available through Xcode.)

I used it for years on systems up to and including Catalina, and it seemed happy enough. I always wanted to check it out on more recent versions (Big Sur and above), but never seemed to get around to it.

Depending on circumstance, I would sometimes have it assigned to the backtick (`) key on my keyboard (rather than the space bar), simply because sometimes I found the backtick key location more convenient on my keyboard.

But most of the time the space bar has been okay: space to QuickLook preview an asset, space to close the preview and return to Unity Editor.
