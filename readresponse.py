def readResponse(response):
    reading_item = False;
    item_index = 0;
    list_index = 0;
    section_index = 0;
    item_string = "";

    items = [];
    sections = [];
    lists = [];

    for letter in response:
        if (letter == "«"):
            item_string = "";
            reading_item = True;
            continue;
        elif (letter == "»"):
            items.append(item_string);
            item_string = "";
            reading_item = False;
            continue;
        elif (letter == "►"):
            item_index+=1;
            continue;
        elif (letter == "▼"):
            sections.append(items);
            items = [];
            section_index+=1;
            continue;
        elif (letter == "¶"):
            lists.append(sections);
            sections = [];
            list_index+=1;
            continue;
        else:
            if (reading_item):
                item_string += letter;

        return lists;