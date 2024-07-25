**Brush Tool**
**Overview**

The Brush Tool is a Windows Forms application that allows users to annotate images by drawing on them using a brush tool. It supports annotating images with different levels of cracks (low, moderate, and high) and saving these annotations in YOLO format. The tool also provides functionality to navigate through images in a folder, save annotations, and manage polygon selections.
Features

    Brush Tool: Draw on images using different brush sizes and colors to indicate different levels of cracks.
    Image Navigation: Navigate through a folder of images to annotate each image.
    Annotation Management: Save annotations in YOLO format, read existing annotations, and remove annotations.
    Polygon Deletion: Select and remove polygons that are drawn and aren't required.

**Installation**

    Clone the repository:

    bash

    git clone https://github.com/yourusername/Brush-Tool.git

    Open the solution file BrushTool.sln in Visual Studio.
    Build the solution to restore the necessary NuGet packages and dependencies.
    Run the application.

**Usage**
**Main UI Components**

    Brush Tool Controls:
        btn_Brush: Toggle the brush tool on and off.
        nud_brushSize: Set the size of the brush.
        rb_lowCrack, rb_modCrack, rb_highCrack: Select the type of crack to annotate (low, moderate, high).

    Image Navigation:
        btn_browseFolder: Browse and select a folder containing images to annotate.
        btn_previous: Navigate to the previous image.
        btn_next: Navigate to the next image.
        tb_outputPath: Displays the selected output path.
        tb_filename: Displays the current image filename.
        tb_Status: Displays the status of the current image (PROCESSED or UNPROCESSED).

    Annotation Management:
        btn_saveSingle: Save a single annotation.
        btn_saveFinalText: Save all annotations for the current image.
        btn_removeRecent: Remove the most recent annotation.
        btn_ReadAnnot: Toggle reading and displaying existing annotations.
        btn_selectPolygon: Enable polygon selection mode and use it to delete false annotations.

**Key Bindings**

    a: Navigate to the previous image.
    d: Navigate to the next image.
    b: Toggle the brush tool.
    o: Open the folder browser to select a folder of images.
    s: Save all annotations for the current image.
    r: Remove the most recent annotation.
    z: Select low crack annotation.
    x: Select moderate crack annotation.
    c: Select high crack annotation.
    t: Toggle reading and displaying existing annotations.

**Annotation Process**

    Select Folder: Click Browse Folder to select the folder containing images.
    Annotate Image:
        Use the brush tool to draw on the image. Select the type of crack using the radio buttons.
        Click Save Single to save the current annotation.
    Save Annotations: Click Save Final Text to save all annotations in YOLO format.
    Navigate: Use the Previous and Next buttons to navigate through images.

**Polygon Selection**

    Enable polygon deletion mode by clicking Remove Polygon.
    Click on the image inside any of the polygon you wish to be removed.
    And toggle the annotations once to refresh the image.

**Code Overview
Main Components**

    Form1: The main form that contains all the UI elements and handles events.
    PolygonHelper: A helper class to delete unnecessary polygons.

**Key Methods**

    btn_browseFolder_Click: Handles folder selection and image loading.
    btn_previous_Click / btn_next_Click: Handles image navigation.
    pb_imgDisplay_MouseDown: Handles mouse down events for drawing and polygon selection.
    pb_imgDisplay_MouseMove: Handles mouse move events for drawing.
    pb_imgDisplay_MouseUp: Handles mouse up events for drawing.
    btn_Brush_Click: Toggles the brush tool.
    btn_saveSingle_Click: Saves a single annotation.
    btn_saveFinalText_Click: Saves all annotations.
    btn_removeRecent_Click: Removes the most recent annotation.
    btn_ReadAnnot_Click: Toggles reading and displaying existing annotations.
    btn_selectPolygon_Click: Enables polygon selection mode.
    Form1_KeyPress: Handles key press events for shortcuts.

**License**

This project is licensed under the MIT License. See the LICENSE file for details.
Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.
Acknowledgments

This project uses the following libraries:

    OpenCvSharp for image processing and computer vision tasks.
    System.Drawing for drawing and graphical operations.
