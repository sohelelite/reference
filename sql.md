###### Change table owner to dbo
`ALTER SCHEMA dbo TRANSFER mediafusion_01user.Spotlight;`

###### Form Structure SQL Statement
`INSERT INTO FormStructure VALUES (26,'Textbox','Title','txtTitle','Title','input-xxlarge','Y',500,'','',1,'Y');`

`INSERT INTO FormStructure VALUES (26,'Textarea','Description','txtDesc','Desc','input-xxlarge','N',0,'','',2,'Y');`

`INSERT INTO FormStructure VALUES (26,'HtmlEditor','Content','txt_Content','Content','','N',0,'{"Editor":{"toolbar":"Intermediate","Height" : "100px","Color":"#fff"}}','',1,'Y');`

`INSERT INTO FormStructure VALUES (26,'ImageUpload','Image','img','Image','','N',0,'{   "Callback" :      {       "ImageUpload":          {           "ImageWidth"  : "120",           "ImageHeight" : "120",           "ControlID"  : "img"          }      }  }','',2,'Y');`

`INSERT INTO FormStructure VALUES (26,'FileUpload','File','file_Article','File','','N',0,'{"FileUpload":{"FileType":"file"}}','',3,'Y');`

`INSERT INTO FormStructure VALUES (26,'Checkbox','Active','chkActive','Active','checkbox','N',0,'','',4,'Y');`

`INSERT INTO FormStructure VALUES (1,'','','','','','',0,'','',1,'Y');`

`INSERT INTO FormStructure VALUES (12,'DropdownList','Country','ddlCountry','CountryID','','Y',0,
'
{
    "Dropdown": {
        "ParentDataSource": "Generic",
        "Generic": {
            "ModelName"         : "Country",
            "DataTextField"     : "CountryName",
            "DataValueField"    : "CountryID"
        }
    }
}
',
'',1,'Y');`

###### Meta Title, Meta Keyword & Meta Desc Insert Query
`INSERT INTO FormStructure VALUES (14,'Textarea','Meta Title','txtMetaTitle','MetaTitle','input-xxlarge','N',0,'','',12,'Y');`

`INSERT INTO FormStructure VALUES (14,'Textarea','Meta Keywords','txtMetaKeyWord','MetaKeyword','input-xxlarge','N',0,'','',13,'Y');`

`INSERT INTO FormStructure VALUES (14,'Textarea','Meta Description','txtMetaDesc','MetaDesc','input-xxlarge','N',0,'','',14,'Y');`

`INSERT INTO FormStructure VALUES (33,'Textbox','Index','txtIndex','Index','input-mini','Y',2,'{"Callback" : {"AcceptNumber":"txtIndex"}}','',12,'Y');`
`INSERT INTO FormStructure VALUES (33,'Checkbox','Active','chkActive','Active','checkbox','N',0,'','',13,'Y');`

