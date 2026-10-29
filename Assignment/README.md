# Explain the Function

## 1. Function Using Reading the File

### ReadLine()
- Reads one line from a file at a time.
- It is used to read text line by line.

### ReadToEnd()
- Reads all remaining text from a file.
- It is used to read text until the end of the file.

### ReadAllText()
- Reads all text from a file and returns it as a string.
- It is used to read the whole file at once.

### StreamReader
- It is a class used to read text from a file.
- It can read a file line by line or read all remaining text.

## 2. Function Used to Delete the File or Item in a File

### File.Delete()
- It is used to delete a file.
- It removes the file if it exists.

### StreamReader
- It is used to read the contents of a file.
- It helps find the item that needs to be deleted.

### StreamWriter
- It is used to write text into a file.
- It can write the remaining items after deleting an item.

### File.Move()
- It is used to move a file to another location or change its name.
- It can replace the original file after creating an updated file with a different name.

### Deleting an Item from a File
- First, read the file using StreamReader.
- Skip the item that needs to be deleted.
- Write the remaining items using StreamWriter.
- Save the updated content back to the file.