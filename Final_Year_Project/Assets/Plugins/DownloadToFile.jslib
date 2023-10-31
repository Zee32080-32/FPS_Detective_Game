mergeInto(LibraryManager.library, {

    downloadToFile: function (PlayerName, Description, filename) {
        const PlayernameStr = Pointer_stringify(PlayerName); 
	const DescriptionStr = Pointer_stringify(Description); 
        const filenameStr = Pointer_stringify(filename);

        const blob = new Blob([PlayernameStr, DescriptionStr, filenameStr], { type: "application/json" });
        const url = URL.createObjectURL(blob, { oneTimeOnly: true });

        const element = document.createElement("a");
        element.href = url;
        element.download = filenameStr;
        element.style.display = "none";
        document.body.appendChild(element);

        element.click();

        document.body.removeChild(element);
    }

});