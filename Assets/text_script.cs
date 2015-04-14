using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class text_script : MonoBehaviour {

	Text textCompenent;
	TextMesh textMesh;
	int currentPos = 0;
	bool doDaStuff=false;

	public void StartWallOfDeath()
	{
		doDaStuff=true;
	}

	private string text_all="Mission: Save the pre-apocalyptic artifacts\n" +
		"Goal: idem\n" +
		"During your mission you will need some oxygene\n " +
		"You can collect oxygene from plants\n " +
		"But the plant will be destroyed\n" +
		"You can plant new plant in the correct area\n" +
		"Your heart will tell you the good spot to plant the seed of life\n" +
		"But this way may lead you in the darkness of your soul\n" +
		"...\n" +
		"\n" +
		"The consequence of your act may be greater than you expect\n" +
		"Good Luck bitch\n" +
		"\n" +
		"May the force be with you -- Gandalf\n" +
		"\n" +
		"Press Esc to quit the text\n"+
		"\n" +
		"Don't forget     to        b r e a t h \n" +
		"\n"+
		"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed \n"+
		"sem libero, pretium a suscipit a, hendrerit in nisi. Etiam\n"+
		" imperdiet diam nulla. Aliquam a sollicitudin quam. Mauris \n"+
		"maximus sem sed felis rhoncus convallis. Maecenas \n"+
		"imperdiet, orci sed finibus malesuada, ligula urna \n"+
		"scelerisque neque, et laoreet purus eros id lacus. \n"+
		"Suspendisse quis lorem tincidunt, luctus nulla vel, \n"+
		"gravida nisi. Pellentesque sodales turpis ac turpis \n"+
		"porttitor dictum. Curabitur non nisi ac enim dignissim \n"+

		"When Aliens (R) wanted to invade the world, they seeked \n"+
		"for the greatest nations to kidnap their people. But the \n"+
		"Aliens (R) faced a big problem, most of the people \n"+
		"commited suecide. After the big Alien conference, it was \n"+
		"clear, Bruxelles had to be reconstructed on their planet.\n"+
		
		"After hours of intensive construction, the Aliens (R) had\n"+
		" constructed the most perfect reconstruction of Bruxells \n"+
		"on their planet ever. Now people could live in peace. \n"+
		"After deporting whole human race to this place, one thing\n"+
		" failed: The Aliens (r) didn't think of the fact that \n"+
		"people can't survive onder water. That day was a sad day \n"+
		"for humanity, everyone died. \n"+
		
		"No, not everyone, one man survived. Our hero was in a \n"+
		"diving suit, and was able to breath just long enouf to \n"+
		"survive till the setting of our game. The Aliens (r) \n"+
		"didn't worry to much about the disparition of the human \n"+
		"race. THey ate all the corpses on a national feast day \n"+
		"and lived hapily ever after.\n"+
		
		"Our hero continious an epic battle for increasing his \n"+
		"life quality. Join him in sseeking the forbidden artifact\n"+
		" in the middle of neo Brussels. A better life may follow!\n"+

		"ullamcorper. Mauris lacinia tellus ac odio rutrum, et \n"+
		"tristique leo feugiat. In in elit id mi volutpat viverra \n"+
		"eget id augue. Nam ullamcorper sem vel odio auctor, eget \n"+
		"maximus urna suscipit. Fusce ac velit aliquam, viverra \n"+
		"sapien placerat, iaculis lacus. Nam dapibus nec nulla eu \n"+
		"tempus. Morbi eget urna eu nisi bibendum mattis at sed \n"+
		"massa. Integer lobortis tortor nec ex suscipit egestas. \n"+
		"Suspendisse vestibulum tempor vestibulum. Ut venenatis \n"+
		"pretium ante, vel consectetur libero dictum sed. Aliquam \n"+
		"vel sapien pulvinar, euismod orci vel, egestas ex. \n"+
		"Praesent nulla orci, cursus a placerat gravida, facilisis \n"+
		"ac lacus. Nullam eget sapien cursus, euismod magna ac, \n"+
		"rutrum velit. Ut sit amet elit rhoncus arcu facilisis \n"+
		"ultrices. Nam sit amet tempor justo. In convallis lacinia \n"+
		"cursus. Vends rein, €1000. sapien est, ac fermentum risus \n"+
		"dictum ut. Sed dignissim, elit sed tristique feugiat, nibh\n"+
		" turpis consequat lacus, et pellentesque ipsum mauris eget \n"+
		"odio. Aliquam tincidunt augue non ultrices facilisis. \n"+
		"Nullam cursus elit eu velit placerat, et imperdiet odio \n"+
		"suscipit. Donec non odio vulputate, finibus est sed, \n"+
		"tempus nisl. Ut vitae lorem tempus, tincidunt lectus eu, \n"+
		"sodales nisl. Proin ut tortor sit amet arcu iaculis auctor\n"+
		" non ac arcu. Sissi ce message est pour toi. tincidunt urna \n"+
		"hendrerit sit amet. Mauris iaculis lectus metus. Morbi ac \n"+
		"tellus sed ligula imperdiet laoreet. Ut ut velit et ipsum \n"+
		"lacinia porta. Sed felis nisl, vestibulum sit amet \n"+
		"porttitor vitae, aliquet ut neque. Curabitur ut lectus \n"+
		"turpis. Pellentesque at nisl ut velit lobortis rhoncus vel\n"+
		" in risus. Nullam et sem nisl. Etiam lacinia ultrices \n"+
		"eleifend. Nullam a congue diam. Duis interdum porta nibh, \n"+
		"ac blandit nunc faucibus vel. Curabitur ullamcorper luctus\n"+
		" tortor quis imperdiet. Ut vitae eros neque. Proin mattis \n"+
		"et ex vel aliquet. Phasellus et quam tellus. Aliquam neque\n"+
		" ligula, tincidunt id pharetra nec, mattis nec enim. Sed eu\n"+
		" mi felis. Vestibulum sed tortor a diam consectetur posuere\n"+
		" et non tellus. Phasellus gravida tellus eget gravida \n"+
		"porta. Je <3 la boef, c'est la vie! Morbi erat libero, \n"+
		"interdum et quam a, pretium bibendum elit. Morbi urna \n"+
		"nisl, venenatis sit amet mauris id, suscipit condimentum \n"+
		"nisi. Ut commodo ultrices suscipit. Vivamus tristique \n"+
		"accumsan felis non pulvinar. In ac magna dictum, luctus \n"+
		"leo sit amet, varius urna. Nunc ultrices mauris turpis, \n"+
		"sit amet molestie felis vulputate ac. Sed in lectus porta \n"+
		"elit efficitur dictum. Ut a tincidunt leo, eu porta nisl. \n"+
		"Cras sem enim, tristique id rhoncus ut, semper et augue. \n"+
		"Nunc porttitor malesuada dui at venenatis. Aenean ac nibh \n"+
		"erat. Lorem ipsum dolor sit amet, consectetur adipiscing \n"+
		"elit. Praesent dictum quam eget quam aliquet elementum. \n"+
		"Proin ut nibh elit. Vivamus convallis odio placerat, \n"+
		"dignissim erat eu, viverra dui. Nulla ornare a mauris sit \n"+
		"amet molestie. Pellentesque fringilla mauris sollicitudin \n"+
		"risus pharetra, a suscipit nulla finibus. Fusce odio \n"+
		"mauris, placerat in ante id, gravida interdum risus. \n"+
		"Aenean pellentesque lorem porta ligula elementum, vitae \n"+
		"iaculis justo facilisis. Cras semper bibendum risus ac \n"+
		"placerat. Praesent mattis magna sed mattis ultricies. Sed \n"+
		"ut metus dapibus, imperdiet lectus quis, facilisis mauris.\n"+
		" Aenean velit erat, laoreet nec mi nec, gravida aliquet \n"+
		"nisi. In eleifend varius odio, vel euismod ante dictum \n"+
		"vel. Nullam ut diam eget diam aliquet convallis in sed \n"+
		"nulla. Ut consectetur vitae eros et aliquam. Quisque id \n"+
		"lectus nisl. Nulla ornare sodales ante, volutpat \n"+
		"ullamcorper ex cursus at. Sed viverra ullamcorper risus \n"+
		"vitae fringilla. Praesent in vehicula tortor, ac rhoncus \n"+
		"dolor. Duis lectus risus, malesuada in ligula ut, varius \n"+
		"viverra odio. Donec elementum eros vitae sapien auctor \n"+
		"venenatis. Nullam volutpat pharetra est. Donec pharetra \n"+
		"purus vitae sodales euismod. Fusce bibendum magna in massa\n"+
		" dapibus commodo. Maecenas ut nunc fermentum, vehicula ex \n"+
		"ut, dignissim dui. Vivamus eget justo nec mi ullamcorper \n"+
		"auctor. Proin sed ullamcorper ex. Pellentesque et felis \n"+
		"sed augue sagittis iaculis at semper augue. Nulla \n"+
		"facilisis malesuada sem, id fringilla metus sagittis a. Ut\n"+
		" id consequat nulla, at bibendum arcu. Suspendisse \n"+
		"porttitor nisi orci, id ultricies metus suscipit in. Nunc \n"+
		"vehicula ut eros nec lacinia. Mauris auctor ipsum \n"+
		"tincidunt eros consectetur commodo. Curabitur vitae massa \n"+
		"felis. Integer iaculis nibh non molestie dapibus. Proin \n"+
		"est odio, luctus commodo tristique et, dignissim sit amet \n"+
		"diam. Curabitur sed massa sit amet diam ultrices \n"+
		"scelerisque. Vivamus sodales, libero in fermentum \n"+
		"ultrices, felis dui iaculis nisi, quis gravida lectus eros\n"+
		" sed est. Nam neque quam, malesuada ut tincidunt ut, \n"+
		"euismod vel enim. Pellentesque ultrices condimentum elit, \n"+
		"a consectetur elit hendrerit at. Fusce ornare pretium \n"+
		"De façon surprenante, le sperme sort à la vitesse du son, \n"+ 
		"provoquant une explosion sonore et une singularité de \n"+ 
		"Prandtl-Glauert sépare les fluides plus denses du sperme \n"+ 
		"et provoque un curieux phénomène : la matière spermiste \n"+ 
		"pure se fixe au visage du garçon comme une colle \n"+ 
		"cyanoacrilate et accueille le rejet spermique suivant \n"+ 
		"comme son propre complément, tandis que les fluides \n"+ 
		"éparpillés par l’explosion s’évacuent en un nuage de fumée \n"+ 
		"blanchâtre. Les deux liquides se mélangent et reforment un \n"+ 
		"sperme blanc neige qui coulent lentement sur l'arcade \n"+ 
		"saillante.\n"+
		"eros, ut tincidunt velit pharetra vel. Aenean vitae orci \n"+
		"ut turpis euismod tincidunt non a tortor. Praesent \n"+
		"volutpat at turpis id cursus. Pellentesque lobortis, ipsum\n"+
		" rutrum rhoncus mollis, arcu purus dignissim nibh, ac \n"+
		"tincidunt nunc risus id nunc. Etiam suscipit elit \n"+
		"convallis ligula scelerisque volutpat. Aliquam justo \n"+
		"felis, mattis nec tellus sit amet, ullamcorper finibus \n"+
		"ligula. Proin molestie pulvinar enim eget tempus. Cras \n"+
		"faucibus posuere pharetra. Vivamus a enim id turpis \n"+
		"tristique ornare. Nunc tincidunt consectetur ipsum, eget \n"+
		"vehicula leo varius non. Nam dui turpis, dignissim vel \n"+
		"justo eget, cursus bibendum lectus. Fusce luctus porttitor\n"+
		" ex, sit amet pulvinar mauris placerat semper. Integer in \n"+
		"leo ligula. Nullam et molestie erat, a vulputate arcu. \n"+
		"Integer pretium, dolor vitae porta condimentum, lacus \n"+
		"justo rhoncus quam, in faucibus est ligula quis orci. In \n"+
		"pulvinar ex a metus aliquet imperdiet. Sed accumsan eu \n"+
		"lectus eu auctor. Integer aliquam, ex a vehicula \n"+
		"imperdiet, tortor purus dapibus felis, ac laoreet libero \n"+
		"ex non mauris. Donec turpis diam, viverra vulputate \n"+
		"aliquam commodo, sagittis sit amet lacus.\n";


	void Start ()
	{
		textCompenent = GetComponent<Text>();
		textCompenent.text = "";
	}

	float timer = 0;

	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
			Destroy(gameObject);
		if (!doDaStuff) return;
		GetComponent<Text>().text = "lalala 0 "; 

		timer += Time.deltaTime;
		if(timer>0.3){
			currentPos++;
		}

		int posKaka = text_all.IndexOf("Lorem ipsum");
		if( currentPos > posKaka )
			currentPos += 3;
		currentPos = Mathf.Min(currentPos, text_all.Length);

		textCompenent.text = text_all.Substring(0, currentPos);
	}
}
